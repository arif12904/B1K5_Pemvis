﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Sub koneksi()
        Try
            If CONN Is Nothing Then
                STR = "server=localhost;userid=root;password=;database=dbtokomainan"
                CONN = New MySqlConnection(STR)
            End If

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
