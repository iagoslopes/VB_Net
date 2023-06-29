<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_cl
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_cl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(105, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(372, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(105, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(105, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(372, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CPF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(372, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Data de Nascimento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(105, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Endereço:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(372, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CEP:"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.Transparent
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(628, 61)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(100, 136)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 8
        Me.img_foto.TabStop = False
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.Window
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.Location = New System.Drawing.Point(105, 79)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 13)
        Me.txt_usuario.TabIndex = 9
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Location = New System.Drawing.Point(372, 78)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(200, 13)
        Me.txt_email.TabIndex = 10
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Location = New System.Drawing.Point(105, 134)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(100, 13)
        Me.txt_senha.TabIndex = 11
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Location = New System.Drawing.Point(105, 189)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(200, 13)
        Me.txt_nome.TabIndex = 12
        '
        'txt_endereco
        '
        Me.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_endereco.Location = New System.Drawing.Point(105, 315)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(200, 13)
        Me.txt_endereco.TabIndex = 15
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Location = New System.Drawing.Point(372, 190)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(86, 13)
        Me.txt_cpf.TabIndex = 17
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cep.Location = New System.Drawing.Point(372, 316)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(65, 13)
        Me.txt_cep.TabIndex = 18
        '
        'txt_data_nasc
        '
        Me.txt_data_nasc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_nasc.Location = New System.Drawing.Point(372, 250)
        Me.txt_data_nasc.Name = "txt_data_nasc"
        Me.txt_data_nasc.Size = New System.Drawing.Size(100, 20)
        Me.txt_data_nasc.TabIndex = 11
        Me.txt_data_nasc.Value = New Date(2023, 3, 28, 0, 0, 0, 0)
        '
        'txt_tel
        '
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tel.Location = New System.Drawing.Point(105, 251)
        Me.txt_tel.Mask = "(99) 99999-9999"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(91, 13)
        Me.txt_tel.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(105, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Telefone:"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.FlatAppearance.BorderSize = 0
        Me.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Location = New System.Drawing.Point(368, 377)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(80, 25)
        Me.btn_cadastrar.TabIndex = 21
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(331, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 31)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(410, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 31)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Entrar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Cadastro_cl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_data_nasc)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Name = "Cadastro_cl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_data_nasc As DateTimePicker
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
