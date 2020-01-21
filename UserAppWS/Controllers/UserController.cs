using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserAppWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        #region Inserir
        [HttpPost]
        public async Task<IActionResult> Create(string email, string nome, string senha)
        {
            try
            {               
                return Ok(new { sucess = true, msg="Usuário criado com sucesso" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");

                return BadRequest(new { sucess = false, msg="Desculpe, algo inesperado aconteceu ao criar o usuário." }); 
            }
        }
        #endregion

        #region Atualizar
        [HttpPost]
        public async Task<IActionResult> Update(string nome, string senha)
        {
            try
            {
                return Ok(new { sucess = true, msg = "Usuário atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");

                return BadRequest(new { sucess = false, msg = "Desculpe, algo inesperado aconteceu ao atualizar o usuário." });
            }
        }
        #endregion

        #region Deletar
        [HttpDelete]
        public async Task<IActionResult> Delete(string nome, string senha)
        {
            try
            {
                return Ok(new { sucess = true, msg = "Usuário deletado com sucesso" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");

                return BadRequest(new { sucess = false, msg = "Desculpe, algo inesperado aconteceu ao deletar o usuário." });
            }
        }
        #endregion

        #region Listar
        #endregion

        #region Trocar Senha
        #endregion

    }
}
