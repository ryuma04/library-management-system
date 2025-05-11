Imports System.Data.OleDb
Public Class AdminProfile
    
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AdminProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet1.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Database2DataSet1.Admin)
        'TODO: This line of code loads data into the 'Database21DataSet.Admin' table. You can move, or remove it, as needed.
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\URUSA SHAIKH\OneDrive\Documents\Visual Studio 2012\Projects\MicroProject\MicroProject\Database2.mdb"
    
    End Sub
End Class
