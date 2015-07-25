
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CommonTools.Win.FormFunc
{
    public partial class CompressForm : BaseForm
    {

        /// <summary>
        /// 需要处理的文件列表
        /// </summary>
        private List<String> _beforeFiles = new List<String>();

        /// <summary>
        ///  更新控件内容的委托
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-25 09:39:02
        private delegate void ThreadWork(string content);

        private Thread _thread;

        public CompressForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        /// <summary>
        ///  窗体关闭
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 15:25:22
        private void CompressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 返回按钮
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 15:25:15
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            Hide();
            start.Show();
        }

        /// <summary>
        ///  选择输入目录
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 15:51:34
        private void BtnImport_Click(object sender, EventArgs e)
        {
            folderDialog.Description = "请选择包含js或css文件的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                TxtImport.Text = folderDialog.SelectedPath;
                //加载文件
                LoadImportFiles(TxtImport.Text.Trim());
            }
        }

        /// <summary>
        ///  加载文件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 15:56:47
        private void LoadImportFiles(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                RchImport.Text = "指定路径不存在！";
                return;
            }
            _beforeFiles.Clear();
            String[] filePaths;
            if ((CobFileType.SelectedIndex == 0) || (CobFileType.SelectedIndex == 1))
            {
                filePaths = Directory.GetFiles(folderPath, "*.js", SearchOption.AllDirectories);
                _beforeFiles.AddRange(filePaths);
            }
            if ((CobFileType.SelectedIndex == 0) || (CobFileType.SelectedIndex == 2))
            {
                filePaths = Directory.GetFiles(folderPath, "*.css", SearchOption.AllDirectories);
                _beforeFiles.AddRange(filePaths);
            }
            if (_beforeFiles.Count <= 0)
            {
                RchImport.Text = "指定路径下没有需要处理的文件！";
                return;
            }
            RchExport.Clear();
            for (int i = 0; i < _beforeFiles.Count; i++)
            {
                RchImport.Text += _beforeFiles[i] + Environment.NewLine;
            }
            FileTotal.Text = "文件总数：" + _beforeFiles.Count;
        }

        /// <summary>
        ///  选择输出目录
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 15:51:55
        private void BtnExport_Click(object sender, EventArgs e)
        {
            folderDialog.Description = "请选择导出的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                TxtExport.Text = folderDialog.SelectedPath;
            }
        }

        /// <summary>
        ///  压缩打包
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 16:43:26
        private void BtnCompress_Click(object sender, EventArgs e)
        {
            string yuiPath = Application.StartupPath + @"\yuicompressor.jar";
            if (_beforeFiles.Count <= 0)
            {
                MessageBox.Show("没有文件需要压缩打包！");
                return;
            }
            if (!File.Exists(yuiPath))
            {
                MessageBox.Show("请先下载yuicompressor.jar！");
                return;
            }
            if (!Directory.Exists(TxtExport.Text.Trim()) && !ChkRetain.Checked)
            {
                MessageBox.Show("请选择导出路径！");
                return;
            }
            loading.ShowWaitForm();
            loading.SetWaitFormCaption("正在拼命压缩打包中...");
            RchExport.Clear();
            RchExport.Focus();
            _thread = new Thread(CrossThread);
            _thread.IsBackground = true;
            _thread.Start();
        }

        /// <summary>
        ///  执行操作
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-25 08:53:28
        private void CrossThread()
        {
            string compressorPath = Application.StartupPath + @"\yuicompressor.jar";
            //循环压缩打包
            for (int i = 0; i < _beforeFiles.Count; i++)
            {
                string content = RunCmd(_beforeFiles[i], compressorPath);
                ThreadFunction(content);
                if (!content.Contains("处理完成"))//报错跳出循环
                {
                    break;
                }
                //Application.DoEvents();//比较耗性能，不建议使用
            }
            loading.CloseWaitForm();
        }

        /// <summary>
        ///  更新控件内容
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-25 08:53:48
        private void ThreadFunction(string content)
        {
            if (RchExport.InvokeRequired)
            {
                ThreadWork work = ThreadFunction;
                Invoke(work, new object[] { content });
            }
            else
            {
                RchExport.AppendText(content);
                RchExport.Refresh();
            }
        }

        /// <summary>
        ///  处理压缩打包
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-07-24 16:59:23
        private string RunCmd(string file, string yuiPath)
        {
            Process iPrcess;
            string fileExtension;//文件后缀
            string fileExport;//导出路径
            string filePath;//导出文件完整路径
            string jsOperation = "";//js独有的参数
            string stringCmd;//cmd执行命令
            StreamReader iReaderOutPut;
            string content;//实时显示内容
            //调用cmd命令符
            iPrcess = new Process();
            iPrcess.StartInfo.FileName = "cmd.exe";
            iPrcess.StartInfo.UseShellExecute = false;
            iPrcess.StartInfo.CreateNoWindow = true;
            iPrcess.StartInfo.RedirectStandardInput = true;
            iPrcess.StartInfo.RedirectStandardOutput = true;
            iPrcess.StartInfo.RedirectStandardError = true;
            iPrcess.Start();
            fileExtension = Path.GetExtension(file);
            fileExport = TxtExport.Text;//导出路径
            if (ChkRetain.Checked)//原地保存
            {
                fileExport = Path.GetDirectoryName(file);
            }
            filePath = fileExport + @"\" + Path.GetFileNameWithoutExtension(file) + (ChkRename.Checked ? "_min" : "") + Path.GetExtension(file);
            if (fileExtension == ".js")//js特有参数
            {
                if (ChkConfused.Checked)
                {
                    jsOperation += " --nomunge ";
                }
                if (ChkSemicolon.Checked)
                {
                    jsOperation += " --preserve-semi ";
                }
                if (ChkOptimization.Checked)
                {
                    jsOperation += " --disable-optimizations ";
                }
            }
            jsOperation += " --charset " + CobFileCode.Text;
            stringCmd = String.Format("java -jar {0} -o {1} {2} {3}", yuiPath, filePath, jsOperation, file);
            iPrcess.StandardInput.WriteLine(stringCmd);
            iPrcess.StandardInput.WriteLine("exit");
            iReaderOutPut = iPrcess.StandardError;
            content = "开始处理 " + file + Environment.NewLine;
            if (iReaderOutPut.EndOfStream)
            {
                content += file + " 处理完成！" + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                while (!iReaderOutPut.EndOfStream)//显示错误信息
                {
                    content += iReaderOutPut.ReadLine() + Environment.NewLine;
                }
            }
            iPrcess.WaitForExit();
            iPrcess.Close();
            iPrcess.Dispose();
            iReaderOutPut.Close();
            iReaderOutPut.Dispose();
            return content;
        }

    }
}
