using QuickBuy.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedidos
        /// </summary>

        public ICollection<ItemPedido> ItemPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItemPedidos.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Crítica - CEP deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Crítica - Não foi informado a forma de pagamento");
        }
    }
}
