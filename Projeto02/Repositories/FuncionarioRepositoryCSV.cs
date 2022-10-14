using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryCSV : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o nome e local do arquivo 
            var path = "c:\\temp\\funcionarios.csv";
            #endregion

            #region Gravando o conteúdo do arquivo

            using (var streamWriter = new StreamWriter(path, true))
            {
                var texto = $"{funcionario.Id};";
                          texto = $"{funcionario.Nome}";
                          texto =  $"{funcionario.DataNascimento.ToString("dd/MM/yyyy")}";
                          texto = $"{funcionario.Cpf}";
                          texto = $"{funcionario.Matricula}";
                          texto = $"{funcionario.DataAdmissao.ToString("dd/MM/yyyy")}";
                          texto = $"{funcionario.Setor.Sigla}";
                          texto = $"{funcionario.Setor.Descricao}";

                streamWriter.WriteLine(texto);
            }

            #endregion
        }
    }
}
