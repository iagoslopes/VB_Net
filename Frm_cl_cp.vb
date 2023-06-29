Public Class Frm_cl_cp

    Private Sub Frm_cl_cp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_prod()
        carregar_tipo_prod()
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao fechar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txt_busca_prod_Click(sender As Object, e As EventArgs) Handles txt_busca_prod.Click
        Try
            SQL = "select * from prod where " & cmb_tipo_prod.Text & " like '" & txt_busca_prod.Text & "%'"
            rs = db.Execute(SQL)
            With dgv_prod
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_prod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prod.CellContentClick
        Try
            With dgv_prod
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_prod = .CurrentRow.Cells(0).Value
                    aux_valor = .CurrentRow.Cells(3).Value
                    resp = MsgBox("Deseja realmente comprar o Produto: " & aux_prod & "" + vbNewLine &
                                       "No valor de: " & aux_valor & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        MsgBox("Produto comprado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sucesso!!!")
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar Dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class