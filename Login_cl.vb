Public Class Login_cl

    Private Sub Login_cl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub Btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            SQL = "select * from cli where usuario='" & txt_user.Text & "' Or email='" & txt_user.Text & "' And senha='" & txt_senha.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then 'se existir
                MsgBox("Conectado com sucesso", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Me.Hide()
                Frm_cl.ShowDialog()
            Else
                MsgBox("Usuário/E-mail e/ou Senha incorreto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If

        Catch ex As Exception
            MsgBox("Erro ao logar com funcionário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

End Class