using ASPNetCoreAjax.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Mime;

namespace ASPNetCoreAjax.Controllers
{
    
    [Authorize]
    public class TransactionController : Controller
    {
        public readonly TransactionDBContext _context;
        public TransactionController(TransactionDBContext context) {
            _context = context;
        }

        // GET: TransactionController
        public ActionResult Index()
        {
            var data = _context.Transactions.Select(x => x).ToList();
            return View(data);
        }

        // GET: TransactionController/Create
        public ActionResult AddOrEdit(int Id = 0)
        {
            Transaction item = new Transaction() { Date=DateTime.Now };
            if (Id != 0)
            {
                item = _context.Transactions.FirstOrDefault(x => x.TransactionId == Id);
                if (item is null)
                    return NotFound();
            }

            return Json(new { isValid = true, html = Helper.RenderRazorToView(this,"AddOrEdit", item) });
            //return View(item);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrEdit(Transaction transaction, int id = 0)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (id == 0)
                        _context.Add(transaction);
                    else
                        _context.Update(transaction);

                    await _context.SaveChangesAsync();
                    return Json(new { isValid = true, html = Helper.RenderRazorToView(this, "_Index", _context.Transactions.ToList()) });
                }
                else
                {
                    return Json(new { isValid = false, html = Helper.RenderRazorToView(this,"AddOrEdit",transaction) });
                }
            }
            catch(Exception ex)
            {
                return Json(new { isValid = false, html = ex.Message });
            }
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                var transaction = _context.Transactions.Find(id);
                _context.Transactions.Remove(transaction);
                await _context.SaveChangesAsync();
                return Json(new { isValid = true, html= Helper.RenderRazorToView(this,"_Index",_context.Transactions.ToList())});
            }
            catch (Exception ex)
            {
                return Json(new { isValid = true, html = ex.Message });
            }
        }
    }
}
