Public Class Menu
    Private Sub EntrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarToolStripMenuItem.Click
        Try
            Login_func.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUCAO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

    Private Sub EntrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntrarToolStripMenuItem1.Click
        Try
            Login_cl.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUÇÃO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click
        Try
            Cadastro_cl.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUÇÃO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

End Class
