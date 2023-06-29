<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_func_cp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_func_cp))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar_prod = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_func_busca_prod = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_func_tipo_prod = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_tipo_prod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.img_prod = New System.Windows.Forms.PictureBox()
        Me.txt_desc_prod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_valor_prod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_prod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_func_prod = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_func_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar_prod, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txt_func_busca_prod, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.cmb_func_tipo_prod, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_salvar_prod
        '
        Me.btn_salvar_prod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar_prod.Image = CType(resources.GetObject("btn_salvar_prod.Image"), System.Drawing.Image)
        Me.btn_salvar_prod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar_prod.Name = "btn_salvar_prod"
        Me.btn_salvar_prod.Size = New System.Drawing.Size(23, 22)
        Me.btn_salvar_prod.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de busca:"
        '
        'txt_func_busca_prod
        '
        Me.txt_func_busca_prod.Name = "txt_func_busca_prod"
        Me.txt_func_busca_prod.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripLabel2.Text = "Tipo de produto"
        '
        'cmb_func_tipo_prod
        '
        Me.cmb_func_tipo_prod.Name = "cmb_func_tipo_prod"
        Me.cmb_func_tipo_prod.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 28)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 421)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.txt_tipo_prod)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.img_prod)
        Me.TabPage1.Controls.Add(Me.txt_desc_prod)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_valor_prod)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nome_prod)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_Registrar)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create/Update"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_tipo_prod
        '
        Me.txt_tipo_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tipo_prod.Location = New System.Drawing.Point(233, 131)
        Me.txt_tipo_prod.Multiline = True
        Me.txt_tipo_prod.Name = "txt_tipo_prod"
        Me.txt_tipo_prod.Size = New System.Drawing.Size(90, 20)
        Me.txt_tipo_prod.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de Produto:"
        '
        'img_prod
        '
        Me.img_prod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_prod.Image = CType(resources.GetObject("img_prod.Image"), System.Drawing.Image)
        Me.img_prod.Location = New System.Drawing.Point(401, 106)
        Me.img_prod.Name = "img_prod"
        Me.img_prod.Size = New System.Drawing.Size(100, 100)
        Me.img_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_prod.TabIndex = 7
        Me.img_prod.TabStop = False
        '
        'txt_desc_prod
        '
        Me.txt_desc_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc_prod.Location = New System.Drawing.Point(233, 216)
        Me.txt_desc_prod.Multiline = True
        Me.txt_desc_prod.Name = "txt_desc_prod"
        Me.txt_desc_prod.Size = New System.Drawing.Size(269, 78)
        Me.txt_desc_prod.TabIndex = 6
        Me.txt_desc_prod.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descrição do Produto:"
        '
        'txt_valor_prod
        '
        Me.txt_valor_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valor_prod.Location = New System.Drawing.Point(233, 173)
        Me.txt_valor_prod.Multiline = True
        Me.txt_valor_prod.Name = "txt_valor_prod"
        Me.txt_valor_prod.Size = New System.Drawing.Size(90, 20)
        Me.txt_valor_prod.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor do Produto:"
        '
        'txt_nome_prod
        '
        Me.txt_nome_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_prod.Location = New System.Drawing.Point(233, 92)
        Me.txt_nome_prod.Multiline = True
        Me.txt_nome_prod.Name = "txt_nome_prod"
        Me.txt_nome_prod.Size = New System.Drawing.Size(163, 20)
        Me.txt_nome_prod.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Produto:"
        '
        'btn_Registrar
        '
        Me.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Registrar.FlatAppearance.BorderSize = 0
        Me.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Registrar.Location = New System.Drawing.Point(327, 322)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(79, 23)
        Me.btn_Registrar.TabIndex = 0
        Me.btn_Registrar.Text = "REGISTRAR"
        Me.btn_Registrar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_func_prod)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(733, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista Produtos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_func_prod
        '
        Me.dgv_func_prod.AllowUserToAddRows = False
        Me.dgv_func_prod.AllowUserToDeleteRows = False
        Me.dgv_func_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_func_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_func_prod.Location = New System.Drawing.Point(4, 3)
        Me.dgv_func_prod.Name = "dgv_func_prod"
        Me.dgv_func_prod.ReadOnly = True
        Me.dgv_func_prod.Size = New System.Drawing.Size(726, 407)
        Me.dgv_func_prod.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "N"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "nome_prod"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "tipo_prod"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "desc_prod"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "valor_prod"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "editar_prod"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "excluir_prod"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Frm_func_cp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_func_cp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edição do Cardápio"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_func_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_salvar_prod As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_func_busca_prod As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_func_tipo_prod As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_func_prod As DataGridView
    Friend WithEvents txt_desc_prod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_valor_prod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_prod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents img_prod As PictureBox
    Friend WithEvents txt_tipo_prod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
