Imports System.Data.OleDb
Imports System.Data

Module Module1
    Public conn As OleDbConnection
    Public Sub ConneDB()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Asmita\Saddam\library.accdb")
        conn.open()
    End Sub
End Module
