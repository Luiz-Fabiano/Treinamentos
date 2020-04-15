using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TreinaWeb.Musicas.AcessoDados.EF.Context;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Musicas.Repositorios.EF;
using TreinaWeb.Musicas.Web.Filtros;
using TreinaWeb.Musicas.Web.ViewModels.Album;
using TreinaWeb.Repostitorios.Comum;

namespace TreinaWeb.Musicas.Web.Controllers
{
    [Authorize]
    public class AlbunsController : Controller
    {
        //private MusicasDbContext db = new MusicasDbContext();

        private IRepositorioGenerico<Album, int> repositorioAlbuns = new AlbunsRepositorio(new MusicasDbContext());

        public ActionResult Index()
        {
            //return View(Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(db.Albums.ToList()));            
            return View(Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(repositorioAlbuns.Selecionar()));
        }

        public ActionResult FiltrarPorNome(string nome)
        {
            List<Album> albuns = repositorioAlbuns.Selecionar().Where(a => a.Nome.Contains(nome)).ToList();
            List<AlbumExibicaoViewModel> viewModels = Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(albuns);
            return Json(viewModels, JsonRequestBehavior.AllowGet);
        }

        // GET: Albuns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Album album = db.Albums.Find(id);
            Album album = repositorioAlbuns.SelecionarPorID(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumExibicaoViewModel>(album));
        }

        // GET: Albuns/Create
        [Authorize(Roles = "Administrador")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Albuns/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        public ActionResult Create([Bind(Include = "ID,Nome,Ano,Observacoes,Email")] AlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Album album = Mapper.Map<AlbumViewModel, Album>(viewModel);
                //db.Albums.Add(album);
                //db.SaveChanges();
                repositorioAlbuns.Inserir(album);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Albuns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Album album = db.Albums.Find(id);
            Album album = repositorioAlbuns.SelecionarPorID(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumViewModel>(album));
        }

        // POST: Albuns/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Ano,Observacoes,Email")] AlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Album album = Mapper.Map<AlbumViewModel, Album>(viewModel);
                //db.Entry(album).State = EntityState.Modified;
                //db.SaveChanges();
                repositorioAlbuns.Alterar(album);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Albuns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Album album = db.Albums.Find(id);
            Album album = repositorioAlbuns.SelecionarPorID(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumExibicaoViewModel>(album));
        }

        // POST: Albuns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Album album = db.Albums.Find(id);
            //db.Albums.Remove(album);
            //db.SaveChanges();
            repositorioAlbuns.ExcluirPorID(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
