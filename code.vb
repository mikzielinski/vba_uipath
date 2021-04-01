Sub PassIn()
	Dim Str1, Str2
	Dim result
	
	Str1 = (WScript.Arguments(0))
	Str2 = (WScript.Arguments(1))
	
	result = Str1& " "& Str2
	
	WScript.Echo result
	End Sub