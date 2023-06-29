<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_func
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_func))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardápioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarEditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardápioToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.ListaToolStripMenuItem.Image = CType(resources.GetObject("ListaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ListaToolStripMenuItem.Text = "Opções"
        '
        'CardápioToolStripMenuItem
        '
        Me.CardápioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarEditarToolStripMenuItem})
        Me.CardápioToolStripMenuItem.Image = CType(resources.GetObject("CardápioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CardápioToolStripMenuItem.Name = "CardápioToolStripMenuItem"
        Me.CardápioToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CardápioToolStripMenuItem.Text = "Cardápio"
        '
        'CadastrarEditarToolStripMenuItem
        '
        Me.CadastrarEditarToolStripMenuItem.Image = CType(resources.GetObject("CadastrarEditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarEditarToolStripMenuItem.Name = "CadastrarEditarToolStripMenuItem"
        Me.CadastrarEditarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastrarEditarToolStripMenuItem.Text = "Cadastrar/Editar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarListaToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EditarListaToolStripMenuItem
        '
        Me.EditarListaToolStripMenuItem.Image = CType(resources.GetObject("EditarListaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarListaToolStripMenuItem.Name = "EditarListaToolStripMenuItem"
        Me.EditarListaToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.EditarListaToolStripMenuItem.Text = "Editar/Lista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-6, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 48)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "StarLanches"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 176)
        Me.Label1.TabIndex = 3
        '
        'Frm_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_func"
        Me.Text = "Funcionários"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarEditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
