namespace Construtor
{
    public class Produto
    {
        public int Numero { get; set; }
        public int Estoque { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Produto(){

        }

        public Produto(string _descricao){
            this.Descricao = _descricao;
        }

        public Produto(int _numero, int _estoque, string _nome, string _descricao){
            this.Numero    = _numero ;
            this.Estoque   = _estoque;
            this.Nome      = _nome;
            this.Descricao = _descricao;
        }
    }
}