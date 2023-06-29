Public Class Frm_func_cl
    Private Sub Frm_func_cl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
    End Sub

    Private Sub Img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            SQL = "select * from cli where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then 'Se o CPF existir
                SQL = "update cli set nome='" & txt_nome.Text & "', usuario='" & txt_usuario.Text & "', " &
                        "data_nasc='" & txt_data_nasc.Value.Date & "', senha='" & txt_senha.Text & "', " &
                        "tel='" & txt_tel.Text & "', email='" & txt_email.Text & "', endereco='" & txt_endereco.Text & "', " &
                        "dir_foto='" & diretorio & "', cep='" & txt_cep.Text & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else
                SQL = "insert into cli values ('" & txt_usuario.Text & "','" & txt_email.Text & "', " &
                    "'" & txt_senha.Text & "', '" & txt_nome.Text & "', '" & txt_cpf.Text & "', " &
                    "'" & txt_tel.Text & "', '" & txt_data_nasc.Value.Date & "', '" & txt_endereco.Text & "', " &
                    "'" & txt_cep.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            End If
            carregar_dados()
            txt_usuario.Clear()
            txt_senha.Clear()
            txt_cpf.Clear()
            txt_nome.Clear()
            txt_data_nasc.Value = Date.Today
            txt_tel.Clear()
            txt_endereco.Clear()
            txt_cep.Clear()
            txt_email.Clear()
            img_foto.Load(Application.StartupPath & "\fotos\Add.png")
            txt_cpf.Focus()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            SQL = "select * from cli where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then 'Se o CPF não existir
                txt_nome.Focus()
            Else
                txt_usuario.Text = rs.Fields(0).Value
                txt_email.Text = rs.Fields(1).Value
                txt_senha.Text = rs.Fields(2).Value
                txt_nome.Text = rs.Fields(3).Value
                txt_tel.Text = rs.Fields(5).Value
                txt_data_nasc.Value = rs.Fields(6).Value
                txt_endereco.Text = rs.Fields(7).Value
                txt_cep.Text = rs.Fields(8).Value
                img_foto.Load(rs.Fields(9).Value)
            End If
        Catch ex As Exception
            MsgBox("Erro ao Consultar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        txt_usuario.Clear()
        txt_senha.Clear()
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_data_nasc.Value = Date.Today
        txt_tel.Clear()
        txt_endereco.Clear()
        txt_cep.Clear()
        txt_email.Clear()
        img_foto.Load(Application.StartupPath & "\fotos\Add.png")
        txt_cpf.Focus()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "select * from cli where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            With dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(6).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(5).Value
                    SQL = "select * from cli where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_usuario.Text = rs.Fields(0).Value
                        txt_email.Text = rs.Fields(1).Value
                        txt_senha.Text = rs.Fields(2).Value
                        txt_nome.Text = rs.Fields(3).Value
                        txt_cpf.Text = rs.Fields(4).Value
                        txt_tel.Text = rs.Fields(5).Value
                        txt_data_nasc.Value = rs.Fields(6).Value
                        txt_endereco.Text = rs.Fields(7).Value
                        txt_cep.Text = rs.Fields(8).Value
                        img_foto.Load(rs.Fields(9).Value)
                    End If
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(5).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                  "o CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "Delete from cli where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados()
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