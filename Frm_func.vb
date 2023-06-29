Public Class Frm_func
    Private Sub CadastrarEditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarEditarToolStripMenuItem.Click
        Try
            Frm_func_cp.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUÇÃO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

    Private Sub EditarListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarListaToolStripMenuItem.Click
        Try
            Frm_func_cl.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUÇÃO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub
End Class