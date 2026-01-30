using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SystemOptimizer
{
    public partial class Form1 : Form
    {
        private Button btnCheckSystem;
        private Button btnOptimize;
        private Button btnScanMalware;
        private TextBox txtOutput;

        public Form1()
        {
            InitializeComponents(); // Método personalizado para criar a UI
        }

        private void InitializeComponents()
        {
            // Configuração do Formulário
            this.Text = "Otimizador de Sistema";
            this.Width = 700;
            this.Height = 500;

            // TextBox para saída
            txtOutput = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                ReadOnly = true
            };

            // Botões
            btnCheckSystem = new Button
            {
                Text = "Verificar Sistema (SFC/DISM)",
                Width = 200,
                Top = 10,
                Left = 10
            };
            btnCheckSystem.Click += btnCheckSystem_Click;

            btnOptimize = new Button
            {
                Text = "Otimizar Desempenho",
                Width = 200,
                Top = 50,
                Left = 10
            };
            btnOptimize.Click += btnOptimize_Click;

            btnScanMalware = new Button
            {
                Text = "Analisar Malware",
                Width = 200,
                Top = 90,
                Left = 10
            };
            btnScanMalware.Click += btnScanMalware_Click;

            // Painel para organizar os botões
            Panel panel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220
            };
            panel.Controls.Add(btnCheckSystem);
            panel.Controls.Add(btnOptimize);
            panel.Controls.Add(btnScanMalware);

            // Adicionar controles ao formulário
            this.Controls.Add(panel);
            this.Controls.Add(txtOutput);
        }

        // Métodos para os botões (mesmo conteúdo anterior)
        private void btnCheckSystem_Click(object sender, EventArgs e)
        {
            RunCommand("sfc /scannow", "Verificação de Arquivos do Sistema (SFC)");
            RunCommand("DISM /Online /Cleanup-Image /RestoreHealth", "Reparo de Imagem do Windows (DISM)");
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            RunCommand("chkdsk /f", "Verificação de Disco (CHKDSK)");
            RunCommand("defrag C: /U /V", "Desfragmentação de Disco");
            RunCommand("powercfg /h off", "Desativar Hibernação");
        }

        private void btnScanMalware_Click(object sender, EventArgs e)
        {
            RunCommand("tasklist", "Lista de Processos em Execução");
            RunCommand("netstat -ano", "Conexões de Rede Ativas");
            MessageBox.Show("Para análise completa de malware, use o Windows Defender.");
        }

        private void RunCommand(string command, string description)
        {
            try
            {
                txtOutput.AppendText($"[{DateTime.Now}] Iniciando: {description}...\n");

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {command}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    txtOutput.AppendText(output);
                    if (!string.IsNullOrEmpty(error))
                        txtOutput.AppendText($"ERRO: {error}\n");

                    txtOutput.AppendText($"[{DateTime.Now}] Concluído: {description}\n\n");
                }
            }
            catch (Exception ex)
            {
                txtOutput.AppendText($"FALHA: {ex.Message}\n");
            }
        }
    }
}
