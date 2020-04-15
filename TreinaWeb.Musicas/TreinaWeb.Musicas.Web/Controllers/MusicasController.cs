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
using TreinaWeb.Musicas.Web.ViewModels.Album;
using TreinaWeb.Musicas.Web.ViewModels.Musica;
using TreinaWeb.Repostitorios.Comum;

namespace TreinaWeb.Musicas.Web.Controllers
{
    [Authorize]
    public class MusicasController : Controller
    {
        //private MusicasDbContext db = new MusicasDbContext();

        private IRepositorioGenerico<Musica, long> repositorioMusicas = new MusicasRepositorio(new MusicasDbContext());

        private IRepositorioGenerico<Album, int> repositorioAlbuns = new AlbunsRepositorio(new MusicasDbContext());

        // GET: Musicas
        public ActionResult Index()
        {
            //var musicas = db.Musicas.Include(m => m.Album);
            //return View(musicas.ToList());
            return View(Mapper.Map<List<Musica>, List<MusicaExibicaoViewModel>>(repositorioMusicas.Selecionar()));
        }

        // GET: Musicas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Musica musica = db.Musicas.Find(id);
            Musica musica = repositorioMusicas.SelecionarPorID(id.Value);
            if (musica == null)
            {
                return HttpNotFound();
            }
            //return View(musica);
            return View(Mapper.Map<Musica, MusicaExibicaoViewModel>(musica));
        }

        // GET: Musicas/Create
        public ActionResult Create()
        {
            //ViewBag.IDAlbum = new SelectList(db.Albums, "ID", "Nome");
            List<AlbumExibicaoViewModel> albuns = Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(repositorioAlbuns.Selecionar());
            SelectList dropDownAlbuns = new SelectList(albuns, "ID", "Nome");
            ViewBag.IDAlbum = dropDownAlbuns;
            return View();
        }

        // POST: Musicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,IDAlbum")] MusicaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Musica musica = Mapper.Map<MusicaViewModel, Musica>(viewModel);
                repositorioMusicas.Inserir(musica);
                //db.Musicas.Add(musica);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.IDAlbum = new SelectList(db.Albums, "ID", "Nome", musica.IDAlbum);
            List<AlbumExibicaoViewModel> albuns = Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(repositorioAlbuns.Selecionar());
            SelectList dropDownAlbuns = new SelectList(albuns, "ID", "Nome");
            ViewBag.IDAlbum = dropDownAlbuns;
            return View(viewModel);
        }

        // GET: Musicas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Musica musica = db.Musicas.Find(id);
            Musica musica = repositorioMusicas.SelecionarPorID(id.Value);
            if (musica == null)
            {
                return HttpNotFound();
            }
            //ViewBag.IDAlbum = new SelectList(db.Albums, "ID", "Nome", musica.IDAlbum);
            //return View(musica);
            List<AlbumExibicaoViewModel> albuns = Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(repositorioAlbuns.Selecionar());
            SelectList dropDownAlbuns = new SelectList(albuns, "ID", "Nome");
            ViewBag.IDAlbum = dropDownAlbuns;
            return View(Mapper.Map<Musica, MusicaViewModel>(musica));
        }

        // POST: Musicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,IDAlbum")] MusicaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(musica).State = EntityState.Modified;
                //db.SaveChanges();
                Musica musica = Mapper.Map<MusicaViewModel, Musica>(viewModel);
                repositorioMusicas.Alterar(musica);
                //return RedirectToAction("Index");
            }
            //ViewBag.IDAlbum = new SelectList(db.Albums, "ID", "Nome", musica.IDAlbum);
            //return View(musica);
            List<AlbumExibicaoViewModel> albuns = Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(repositorioAlbuns.Selecionar());
            ViewBag.IDAlbum = new SelectList(albuns, "ID", "Nome");
            return View(viewModel);
        }

        // GET: Musicas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Musica musica = db.Musicas.Find(id);
            Musica musica = repositorioMusicas.SelecionarPorID(id.Value);
            if (musica == null)
            {
                return HttpNotFound();
            }
            //return View(musica);
            return View(Mapper.Map<Musica, MusicaExibicaoViewModel>(musica));
        }

        // POST: Musicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            //Musica musica = db.Musicas.Find(id);
            //db.Musicas.Remove(musica);
            //db.SaveChanges();
            repositorioMusicas.ExcluirPorID(id);
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
