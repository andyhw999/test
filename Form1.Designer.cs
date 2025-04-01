namespace MyWinformApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form11111";


        Button button = new Button(); // 创建一个按钮实例
        button.Text = "点击我"; // 设置按钮文本
        button.Click += Button_Click; // 为按钮的Click事件绑定事件处理程序
        button.Location = new System.Drawing.Point(100, 100); // 设置按钮位置
        this.Controls.Add(button); // 将按钮添加到窗体中
    }
    private static void Button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("按钮被点击了！"); // 显示一个消息框
    }
    #endregion
}
