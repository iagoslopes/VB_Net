Public Class Login_func

    Private Sub Login_func_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            SQL = "select * from func where login='" & txt_login.Text & "' And pass='" & txt_pass.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then 'se existir
                MsgBox("Funcionário conectado com sucesso", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Me.Hide()
                Frm_func.ShowDialog()
            Else
                MsgBox("Usuário e/ou Senha incorreto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If

        Catch ex As Exception
            MsgBox("Erro ao logar com funcionário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

End Class