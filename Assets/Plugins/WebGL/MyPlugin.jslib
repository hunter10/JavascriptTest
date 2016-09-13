var MyPlugin = {
    Hello: function(str)
    {
		window.alert(str + ", " + str);
    },
    HelloString: function(str1, str2, str3, str4)
    {
		commonCall(Pointer_stringify(str1), Pointer_stringify(str2), Pointer_stringify(str3), Pointer_stringify(str4));
    },
    PrintFloatArray: function(array, size)
    {
        for(var i=0;i<size;i++)
            console.log(HEAPF32[(array>>2)+size]);
    },
    AddNumbers: function(x,y)
    {
        return x + y;
    },
    StringReturnValueFunction: function()
    {
        var returnStr = "bla";
        var buffer = _malloc(returnStr.length + 1);
        writeStringToMemory(returnStr, buffer);
        return buffer;
    },
    BindWebGLTexture: function(texture)
    {
        GLctx.bindTexture(GLctx.TEXTURE_2D, GL.textures[texture]);
    }
};

mergeInto(LibraryManager.library, MyPlugin);