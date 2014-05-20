Imports System

Public Class Form1
	'構造体配列のｿｰﾄﾌﾟﾛｸﾞﾗﾑ
	'【参考URL】http://hanatyan.sakura.ne.jp/patio/read.cgi?no=146

	Private Structure CompanyStaff
		Implements IComparable

		Public Code As String
		Public Name As String

		'[比較関数][IComparable]ｲﾝﾀｰﾌｪｰｽを実装すると自動作成される
		Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
			Return Me.Code.CompareTo(DirectCast(obj, CompanyStaff).Code)
		End Function
	End Structure

	'[確認]構造体配列がちゃんとｿｰﾄされている？
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Dim Person As CompanyStaff()	'CompanyStaffの配列である事！
		ReDim Person(3)
		Person(0).Code = "0004" : Person(0).Name = "すずき-0004"
		Person(1).Code = "0003" : Person(1).Name = "あらき-0003"
		Person(2).Code = "0005" : Person(2).Name = "やまだ-0005"
		Person(3).Code = "0006" : Person(3).Name = "たなか-0006"

		Console.WriteLine("ｿｰﾄ前")
		'[ﾙｰﾌﾟ]配列分
		For Each w As CompanyStaff In Person
			Console.WriteLine(w.Name)
		Next

		Console.WriteLine("ｿｰﾄ後")
		'[ｿｰﾄ]
		Array.Sort(Person)
		For Each w As CompanyStaff In Person
			Console.WriteLine(w.Name)
		Next
	End Sub
End Class
