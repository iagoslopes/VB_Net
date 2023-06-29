Public Class Frm_cl
    Private Sub CardápioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardápioToolStripMenuItem.Click
        Try
            Frm_cl_cp.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUÇÃO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

    Private Sub SobreNósToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreNósToolStripMenuItem.Click
        Try
            Frm_cl_sn.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUÇÃO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub
End Class