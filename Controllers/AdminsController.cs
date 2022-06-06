using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RoleBasedAuthorization.Models;

namespace RoleBasedAuthorization.Controllers
{
    public class AdminsController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public static IConfiguration Configuration;

        public AdminsController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        // GET: Admins
        [AuthorizedAction]
        public async Task<IActionResult> Index()
        {
           
            var myDbContext = _context.Admins.Include(a => a.Roles);
            return View(await myDbContext.ToListAsync());
        }
        
        // GET: Admins/Create
        [AuthorizedAction]
        public IActionResult Create()
        {
            int roleId = (int)HttpContext.Session.GetInt32("role_id");

            var _role = _context.Roles.Where(s => s.Id == roleId).FirstOrDefault();
            if (_role.Title.Contains("Annotator"))
            {
                ViewBag.RoleLevel = _role.Title;
            }
            ViewBag.level = new SelectList(_context.Levels, "Id", "Level");
            ViewBag.RolesId = new SelectList(_context.Roles, "Id", "Title");
            ViewBag.userrole = new SelectList(PopulateRole(), "Id", "FullName", 1);
            return View();
        }
        public IEnumerable<SelectListItem> GetUserlist()
        {
            List<SelectListItem> list = null;

            using (var context = new MyDbContext())
            {
                // Queries DB for list of categories by AccountID
                var query = (from ca in context.Admins
                             orderby ca.FullName
                             select new SelectListItem { Text = ca.FullName, Value = ca.Id.ToString() }).Distinct();
                list = query.ToList();

            }

            return list;
        }

        public IEnumerable<SelectListItem> GetUserEditlist(int Id)
        {
            List<SelectListItem> list = null;

            using (var context = new MyDbContext())
            {
                // Queries DB for list of categories by AccountID
                var query = (from ca in context.Admins
                             where ca.Id == Id
                             orderby ca.FullName
                             select new SelectListItem { Text = ca.FullName, Value = ca.Id.ToString() }).Distinct();
                list = query.ToList();

            }

            return list;
        }
        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,FullName,Email,Password,RolesId,Level,parentadminroleid")] Admins admins)
        {
            if (ModelState.IsValid)
            {
                var parentId = Request.Form["Parentadminroleid"].ToString();
                if (String.IsNullOrEmpty(parentId))
                {
                    parentId = "1";
                }
                admins.FullName = admins.FullName;
                admins.parentadminroleid = Convert.ToInt32(parentId);
                admins.Level = admins.Level;
                //admins.status = "Processing";
                _context.Add(admins);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RolesId"] = new SelectList(_context.Roles, "Id", "Title", admins.RolesId);

            return View(admins);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var admins = await _context.Admins.FindAsync(id);
            if (admins == null)
            {
                return NotFound();
            }
            
            admins.parentadminroleid = admins.parentadminroleid;
            //admins.Level = admins.Level;
            int roleId = (int)HttpContext.Session.GetInt32("role_id");

            var _role = _context.Roles.Where(s => s.Id == roleId).FirstOrDefault();
            if (_role.Title.Contains("Annotator"))
            {
                ViewBag.RoleLevel = _role.Title;
            }
            ViewBag.userrole = new SelectList(PopulateRole(), "Id", "FullName", admins.parentadminroleid);
            ViewData["levelId"] = new SelectList(PopulateLevel(), "Id", "Level", admins.Level);
            ViewData["RolesId"] = new SelectList(_context.Roles, "Id", "Title", admins.RolesId);
            return View(admins);
        }
        private List<Admins> PopulateRole()
        {

            MySqlConnection con = null;
            List<Admins> items = new List<Admins>();

            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            string query = "select Id,Full_Name from Admins";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new Admins
                        {
                            Id = Convert.ToInt32(sdr["Id"]),
                            FullName = Convert.ToString(sdr["Full_Name"])
                        });
                    }
                }
                con.Close();
            }
            return items;
        }

        private List<Levels> PopulateLevel()
        {

            MySqlConnection con = null;
            List<Levels> items = new List<Levels>();

            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            string query = "select Id,Level from Levels";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new Levels
                        {
                            Id = Convert.ToString(sdr["Id"]),
                            Level = Convert.ToString(sdr["Level"])
                        });
                    }
                }
                con.Close();
            }
            return items;
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,RolesId,level,parentadminroleid")] Admins admins)
        {
            if (id != admins.Id)
            {
                return NotFound();
            }
            var Level = Request.Form["LevelId"].ToString();
            if (String.IsNullOrEmpty(admins.parentadminroleid.ToString()))
            {
                admins.parentadminroleid = 1;
            }
            Admins admin = await _context.Admins.Where(s => s.Id == admins.Id).FirstOrDefaultAsync();
            admin.FullName = admins.FullName;
            admin.Email = admins.Email;
            admin.RolesId = admins.RolesId;
            admin.Level = Level;
            admin.parentadminroleid = admins.parentadminroleid;
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _context.Admins
                .Include(a => a.Roles)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (admins == null)
            {
                return NotFound();
            }

            return View(admins);
        }

        // POST: Admins/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _context.Admins.SingleOrDefaultAsync(m => m.Id == id);
            _context.Admins.Remove(admins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminsExists(int id)
        {
            return _context.Admins.Any(e => e.Id == id);
        }
    }
}
