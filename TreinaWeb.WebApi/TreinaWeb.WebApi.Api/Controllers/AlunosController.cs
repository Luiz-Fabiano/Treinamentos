using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using TreinaWeb.Comum.Repositorios.Interfaces;
using TreinaWeb.WebApi.AcessoDados.EF.Context;
using TreinaWeb.WebApi.Api.AutoMapper;
using TreinaWeb.WebApi.Api.DTOs;
using TreinaWeb.WebApi.Api.Filters;
using TreinaWeb.WebApi.Dominio;
using TreinaWeb.WebApi.Repositorios.EF;

namespace TreinaWeb.WebApi.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/alunos")]
    public class AlunosController : ApiController
    {
        private IRepositorioTreinaWeb<Aluno, int> _repositorioAlunos = new RepositorioAlunos(new WebApiDbContext());

        //public IEnumerable<Aluno> Get()
        //{
        //    return _repositorioAlunos.Selecionar();
        //}

        public IHttpActionResult Get()
        {
            List<Aluno> alunos = _repositorioAlunos.Selecionar();
            List<AlunoDTO> dtos = AutoMapperManager.Instance.Mapper.Map<List<Aluno>, List<AlunoDTO>>(alunos);
            return Ok(dtos);
            //return Ok(_repositorioAlunos.Selecionar());
        }

        //public HttpResponseMessage Get(int? ID)
        //{
        //    if (!ID.HasValue)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }
        //    Aluno aluno = _repositorioAlunos.SelecionarPorID(ID.Value);
        //    if(aluno == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.Found, aluno);
        //}

        public IHttpActionResult Get(int? ID)
        {
            if (!ID.HasValue)
            {
                return BadRequest();
            }
            Aluno aluno = _repositorioAlunos.SelecionarPorID(ID.Value);
            if (aluno == null)
            {
                return NotFound();
            }
            AlunoDTO dto = AutoMapperManager.Instance.Mapper.Map<Aluno, AlunoDTO>(aluno);
            //return Content(HttpStatusCode.Found, aluno);
            return Content(HttpStatusCode.OK, dto);
        }

        [Route("por-nome/{nomeAluno}")]
        public IHttpActionResult Get(string nomeAluno)
        {
            List<Aluno> alunos = _repositorioAlunos.Selecionar(s => s.Nome.ToLower().Contains(nomeAluno.ToLower()));
            List<AlunoDTO> dtos = AutoMapperManager.Instance.Mapper.Map<List<Aluno>, List<AlunoDTO>>(alunos);
            return Ok(dtos);
        }

        //public HttpResponseMessage Post([FromBody]Aluno aluno)
        //{
        //    try
        //    {
        //        _repositorioAlunos.Inserir(aluno);
        //        return Request.CreateResponse(HttpStatusCode.Created);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}

        //public IHttpActionResult Post([FromBody]Aluno aluno)

        [ApplyModelValidation]
        public IHttpActionResult Post([FromBody]AlunoDTO dto)
        {
            try
            {
                Aluno aluno = AutoMapperManager.Instance.Mapper.Map<AlunoDTO, Aluno>(dto);
                _repositorioAlunos.Inserir(aluno);
                return Created($"{Request.RequestUri}/{aluno.ID}", aluno);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        [ApplyModelValidation]
        //public IHttpActionResult Put(int? ID, [FromBody]Aluno aluno)
        public IHttpActionResult Put(int? ID, [FromBody]AlunoDTO dto)
        {
            try
            {
                if (!ID.HasValue)
                {
                    return BadRequest();
                }
                Aluno aluno = AutoMapperManager.Instance.Mapper.Map<AlunoDTO, Aluno>(dto);
                aluno.ID = ID.Value;
                _repositorioAlunos.Atualizar(aluno);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }
        }

        public IHttpActionResult Delete(int? ID)
        {
            try
            {
                if (!ID.HasValue)
                {
                    return BadRequest();
                }
                Aluno aluno = _repositorioAlunos.SelecionarPorID(ID.Value);
                if (aluno == null)
                {
                    return NotFound();
                }
                _repositorioAlunos.ExcluirPorID(ID.Value);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
