using System;
using System.Windows.Forms;
using GestaoEquipamentos.Modelo;

namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
        // TODO Fase 1: criar o campo público EquipamentoCriado (do tipo Equipamento)
        public Equipamento EquipamentoCriado;
        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        private Equipamento equipamentoEmEdicao;

        // Construtor para ADICIONAR
        public FormEquipamento()
        {
            InitializeComponent();
            Text = "Adicionar equipamento";
        }

        // TODO Fase 1: criar um segundo construtor, para EDITAR, que recebe o equipamento selecionado,
        //              o guarda em equipamentoEmEdicao e preenche as caixas com os dados dele

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string sala = txtSala.Text;

            int ano = int.Parse(nudAno.Text);
            decimal preco = decimal.Parse(nudPreco.Text);
            //mete as imformações nas caixas (txt)
            if (marca == "" || modelo == "" || sala == "")
            {
                MessageBox.Show("Preenche todos os campos!");
                return;
            }//verifica se n falta nenhuma imformação
            EquipamentoCriado = new Equipamento(marca, modelo, sala, ano, preco);

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 6: ativar só o grupo do tipo escolhido (grpComputador, grpImpressora, grpProjetor)
        }
    }
}
