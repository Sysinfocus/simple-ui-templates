function init() {
    if ("Notification" in window) {
        if (Notification.permission === "default") {
            Notification.requestPermission().then(permission => {
                if (permission === "granted")  return true;
                else return false;
            });
        }
        return true;
    }
    else {
        return false;
    }
}

function sendNotification(title, body, icon = null, url = null, tag = null) {
    const options = { body: body, icon: icon, url: url, tag: tag };
    if (Notification.permission === "granted") {
        const notification = new Notification(title, options);
        if (url) {
            notification.onclick = function () { window.open(url, '_blank'); notification.close(); };
        }
        return true;
    } else {
        return false;
    }
}