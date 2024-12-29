const {app, BrowserWindow} = require('electron');

app.on('window-all-closed', function() {
	
  if (process.platform != 'darwin') {
    app.quit();
  }
});

app.on('ready', function() {
  let mainWindow = new BrowserWindow({
		width: 1920,
		height: 1080,
		fullscreen: true,
		backgroundColor: '#000000',
		"node-integration": "iframe",
		"web-preferences": {
			"web-security": false
		}
	});
  mainWindow.setMenu(null);
  mainWindow.loadURL('file://' + __dirname + '/index.html');
  mainWindow.maximize();
});
