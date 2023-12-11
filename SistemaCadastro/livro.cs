using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class livro
    {
        string titulo;
        int genero;
        string autor;
        int paginas;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Genero { get => genero; set => genero = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Paginas { get => paginas; set => paginas = value; }
    }
}
