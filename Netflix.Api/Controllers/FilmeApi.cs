using Microsoft.AspNetCore.Mvc;
using Netflix.Api.Models;
using Netflix.Api.Services;

namespace Netflix.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeApi : ControllerBase
{
    private readonly IFilmeService _filmeService;

    public FilmeApi(IFilmeService filmeService){
        _filmeService = filmeService;
    }

    [HttpGet("/")]
    public List<Filme> Get_List(){
        return _filmeService.ListarFilmes();
    }

    [HttpGet("/Get_Name/{id}")]
    public Filme? Get_Name(string id){
        return _filmeService.ObterFilme(id);
    }

    [HttpPost("/")]
    public bool Salvar_Filme([FromBody] Filme filme){
        return _filmeService.SalvarFilme(filme);
    }

    [HttpPut("/{id}")]
    public bool Alterar_Filme(string id, [FromBody] Filme filme){
        return _filmeService.AlterarFilme(filme);
    }

    [HttpDelete("/{id}")]
    public bool Deletar_Filme(string id)
    {
        return _filmeService.DeletarFilme(id);
    }

}


