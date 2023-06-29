Module Module1
    Public diretorio, SQL, aux_cpf, aux_prod, aux_valor, resp As String 'Variavel Querys
    Public cont As Integer 'ID clientes
    Public db As New ADODB.Connection 'variavel banco
    Public rs As New ADODB.Recordset 'variavel tabela

    Sub conectar_banco()
        Try
            'String de conexão com SQL-Server
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-PVS0UJ2\SQLEXPRESS;Initial Catalog=starlanches;trusted_connection=yes;")
        Catch ex As Exception
            MsgBox("Erro ao conectar no BD", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            SQL = "select * from cli order by nome asc"
            rs = db.Execute(SQL)
            With Frm_func_cl.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_tipo()
        Try
            With Frm_func_cl.cmb_tipo.Items
                .Add("CPF")
                .Add("NOME")
            End With
            Frm_func_cl.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar dados de busca", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_prod()
        Try
            SQL = "select * from prod order by tipo_prod asc"
            rs = db.Execute(SQL)
            With Frm_cl_cp.dgv_prod
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Sub carregar_tipo_prod()
        Try
            With Frm_cl_cp.cmb_tipo_prod.Items
                .Add("TIPO_PROD")
                .Add("NOME_PROD")
                .Add("VALOR_PROD")
            End With
            Frm_cl_cp.cmb_tipo_prod.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar dados de busca", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_func_prod()
        Try
            SQL = "select * from prod order by tipo_prod asc"
            rs = db.Execute(SQL)
            With Frm_func_cp.dgv_func_prod
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Sub carregar_func_tipo_prod()
        Try
            With Frm_func_cp.cmb_func_tipo_prod.Items
                .Add("TIPO_PROD")
                .Add("NOME_PROD")
                .Add("VALOR_PROD")
            End With
            Frm_func_cp.cmb_func_tipo_prod.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar dados de busca", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

End Module
