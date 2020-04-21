using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetodeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)FormaPagamentoEnum.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return Id == (int)FormaPagamentoEnum.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)FormaPagamentoEnum.Deposito; }
        }

        public bool NaoFoiDefinido
        {
            get { return Id == (int)FormaPagamentoEnum.NaoDefinido; }
        }
    }
}
