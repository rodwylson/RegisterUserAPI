using System;
using UserWS.Context;

namespace UserWS.Domain
{
    public class User
    {
        public User Infra { get; set; }

        public User()
        {
            Infra = new User();
        }
       

        #region Inserir        
        public bool Create(string email, string nome, string senha)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");

                return false;
            }
        }
        #endregion

        #region Atualizar
 
        public bool Update(string nome, string senha)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");

                return true;
            }
        }
        #endregion

        #region Deletar
        public bool Delete(string nome, string senha)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");

                return false;
            }
        }
        #endregion

        #region Listar
        #endregion

        #region Trocar Senha
        #endregion
    }
}
