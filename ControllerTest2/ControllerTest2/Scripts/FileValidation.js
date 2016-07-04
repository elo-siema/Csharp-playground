function ValidateFile(file)
{
    file.split("\n");
    for (var i = 1; i >= file.length; i++)
    {
        var line = file[i].split(",");
        if (line.length != 3) {
            
        }
    }
    return true;
}