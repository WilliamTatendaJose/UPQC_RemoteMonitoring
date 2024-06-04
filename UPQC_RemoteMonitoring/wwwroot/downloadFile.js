function downloadFile(fileName, fileUrl) {
    var link = document.createElement('a');
    link.href = fileUrl;
    link.download = fileName;
    link.click();
}