Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms

Namespace SvgDataAdapterSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#SvgFileDataAdapter"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetExecutingAssembly().Location)
            map.Layers.Add(New VectorItemsLayer With {.Data = New SvgFileDataAdapter With {.FileUri = New Uri(baseUri, "..\..\Data\countries.svg")}})
        End Sub
#End Region  ' #SvgFileDataAdapter
    End Class
End Namespace
