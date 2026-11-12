using GestaoEquipamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
// TODO Fase 1: depois de criar a classe Equipamento na pasta Modelo, acrescentar:
//              using GestaoEquipamentos.Modelo;

namespace GestaoEquipamentos.Interface
{
    public partial class FormPrincipal : Form
    {
        // TODO Fase 1: criar o campo List<Equipamento> equipamentos (já com new)
        private List<Equipamento> equipamentos = new List<Equipamento>();

        public FormPrincipal()
        {
            InitializeComponent();
            equipamentos.Add(new Equipamento("HP", "ProDesk", "B12", 2020, 650));
            equipamentos.Add(new Equipamento("testa","protest","T3t",4060,720));
            MostrarEquipamentos();
            // TODO Fase 1: no fim do construtor, chamar MostrarEquipamentos()
        }

        // TODO Fase 1: criar o método MostrarEquipamentos(), que limpa a ListView
        //              (lvEquipamentos.Items.Clear()) e junta uma linha por equipamento.
        //              Ordem das colunas: Id, Tipo, Marca, Modelo, N.º de série, Sala, Ano,
        //              Preço, Estado, Valor atual. Por agora, Id, Tipo, N.º de série, Estado
        //              e Valor atual ficam vazias ("").
        //              Dica:  ListViewItem linha = new ListViewItem("");
        //                     linha.SubItems.Add("");  linha.SubItems.Add(equipamento.Marca); ...
        //                     lvEquipamentos.Items.Add(linha);

        // ---------- Botões ----------
        private void MostrarEquipamentos()
        {
            lvEquipamentos.Items.Clear();


            foreach (Equipamento equipamento in equipamentos)
            {
                ListViewItem linha = new ListViewItem("");

                linha.SubItems.Add("");
                linha.SubItems.Add(equipamento.Marca);
                linha.SubItems.Add(equipamento.Modelo);
                linha.SubItems.Add("");
                linha.SubItems.Add(equipamento.Sala);
                linha.SubItems.Add(equipamento.Ano_Aquisicao.ToString());
                linha.SubItems.Add(equipamento.Preco_Compra.ToString());
                linha.SubItems.Add("");
                linha.SubItems.Add("");
                //algumas colonas estão vazias pq n temos dados sobre elas ainda

                lvEquipamentos.Items.Add(linha);//mete a linha no grafico la
            }

            lblResumo.Text = "Equipamentos na lista: " + equipamentos.Count; //diz o numero de equipamentos
        }
        
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: abrir o FormEquipamento com ShowDialog(); se devolver DialogResult.OK,
            //              juntar form.EquipamentoCriado à lista e chamar MostrarEquipamentos()
            FormEquipamento form = new FormEquipamento();

            if (form.ShowDialog() == DialogResult.OK)
            {
                equipamentos.Add(form.EquipamentoCriado);

                MostrarEquipamentos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              abrir new FormEquipamento(equipamento) e, se devolver OK,
            //              chamar MostrarEquipamentos()
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              pedir confirmação, retirar da lista e pôr a variável a null
        }

        private void lvEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 1: mostrar em txtDetalhes os dados do equipamento selecionado
            
        }

        // Duplo clique numa linha = Editar
        private void lvEquipamentos_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void btnAlterarResponsavel_Click(object sender, EventArgs e)
        {
            // TODO Fase 2: alterar o responsável de informática com Escola.AlterarResponsavel(...)
        }

        // ---------- Pesquisa e filtros ----------

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // TODO Fase 5: mostrar só os equipamentos devolvidos por gestor.Pesquisar(txtPesquisa.Text)
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnImpressorasCores_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só as impressoras a cores (gestor.ObterImpressorasACores())
        }

        private void btnPoucaRam_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só os computadores com 4 GB de RAM ou menos
            //              (gestor.ObterComputadoresComPoucaRam(4))
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 8: mostrar só os equipamentos do estado escolhido (gestor.Pesquisar(estado))
        }
    }
}
