

.PHONY: clean snippet

#�{����src/**/*.csx���ˑ����������������A���܁c
snippet: 
	dotnet run -p SnippetGenerator/CSSnippetGenerator/CSSnippetGenerator.csproj ./

clean: 
	rm -r snippets

