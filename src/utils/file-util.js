import fs from 'fs';

export const read = (fileName) => {
    var _data = "";

    try {
        _data = fs.readFileSync(fileName, "ascii");
    }
    catch (err) {
        console.error("There was an error opening the file:");
        console.log(err);
    }

    return _data;
}

export const write = (fileName, content) => {
    fs.writeFileSync(fileName, content);
}

// Done
export const fileOrDirExists = (dirName, contentName) => {
    var exists = false;
    var contents = fs.readdirSync(dirName);

    contents.forEach(content => {
        if(content == contentName) {
            exists = true;
        }
    });

    return exists;
}

export const listDir = (dirName) => {
    return fs.readdirSync(dirName);
}

export const makeDirectory = (path) => {
    fs.mkdir(path);
}

// Private Functions