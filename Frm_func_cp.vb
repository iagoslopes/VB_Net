Public Class Frm_func_cp
    Private Sub Frm_func_cp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_func_prod()
        carregar_func_tipo_prod()
    End Sub


    Private Sub txt_func_busca_prod_TextChanged(sender As Object, e As EventArgs) Handles txt_func_busca_prod.TextChanged
        Try
            SQL = "select * from prod where " & cmb_func_tipo_prod.Text & " like '" & txt_func_busca_prod.Text & "%'"
            rs = db.Execute(SQL)
            With dgv_func_prod
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub img_prod_Click(sender As Object, e As EventArgs) Handles img_prod.Click
        Try
            With OpenFileDialog1
                .Title = "selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_prod.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_salvar_prod_Click(sender As Object, e As EventArgs) Handles btn_salvar_prod.Click
        Try
            txt_valor_prod.Text = Replace(txt_valor_prod.Text, ",", ".")
            SQL = "select * from prod where nome_prod='" & txt_nome_prod.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then 'Se o Produto existir
                SQL = "update prod set nome_prod='" & txt_nome_prod.Text & "', tipo_prod='" & txt_tipo_prod.Text & "', " &
                        "desc_prod='" & txt_desc_prod.Text & "', valor_prod='" & txt_valor_prod.Text & "', " &
                        "dir_foto='" & diretorio & "' where nome_prod='" & txt_nome_prod.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                carregar_func_prod()
                carregar_prod()
                txt_nome_prod.Clear()
                txt_tipo_prod.Clear()
                txt_desc_prod.Clear()
                txt_valor_prod.Clear()
                img_prod.Load(Application.StartupPath & "\fotos\Add_prods.png")
                txt_nome_prod.Focus()
            Else
                MsgBox("Registre o item primeiro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro ao atualizar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Try
            txt_valor_prod.Text = Replace(txt_valor_prod.Text, ",", ".")
            SQL = "select * from prod where nome_prod='" & txt_nome_prod.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then 'Se o Produto não existir
                SQL = "insert into prod values ('" & txt_nome_prod.Text & "','" & txt_tipo_prod.Text & "', " &
                        "'" & txt_desc_prod.Text & "', '" & txt_valor_prod.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                carregar_func_prod()
                carregar_prod()
                txt_nome_prod.Clear()
                txt_tipo_prod.Clear()
                txt_desc_prod.Clear()
                txt_valor_prod.Clear()
                img_prod.Load(Application.StartupPath & "\fotos\Add_prods.png")
                txt_nome_prod.Focus()
            Else
                MsgBox("Produto ja existente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txt_nome_prod_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome_prod.DoubleClick
        txt_nome_prod.Clear()
        txt_tipo_prod.Clear()
        txt_desc_prod.Clear()
        txt_valor_prod.Clear()
        img_prod.Load(Application.StartupPath & "\fotos\Add_prods.png")
        txt_nome_prod.Focus()
    End Sub

    Private Sub dgv_func_prod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_func_prod.CellContentClick
        Try
            With dgv_func_prod
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_prod = .CurrentRow.Cells(0).Value
                    SQL = "select * from prod where nome_prod='" & aux_prod & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_nome_prod.Text = rs.Fields(0).Value
                        txt_tipo_prod.Text = rs.Fields(1).Value
                        txt_desc_prod.Text = rs.Fields(2).Value
                        txt_valor_prod.Text = rs.Fields(3).Value
                        img_prod.Load(rs.Fields(4).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_prod = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                  "o Produto: " & aux_prod & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "Delete from prod where nome_prod='" & aux_prod & "'"
                        rs = db.Execute(SQL)
                        carregar_prod()
                        carregar_func_prod()
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