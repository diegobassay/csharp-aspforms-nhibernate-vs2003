using System;

namespace MapeamentoOR
{
    [Serializable]
    public class Atividade
    {
        private int _id;
        private string _nome;
        private string _descricao;

        public Atividade()
        {
            _id = 0;
            _nome = null;
            _descricao = null;
        }

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public virtual string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}