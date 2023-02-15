function generateQRCode() {
    // Get the input URL from the user
    var url = document.getElementById("url").value;
  
    if (url === "") {
      alert("Please enter a URL.");
      return;
    }
  
    // Generate the QR code
    var qr = qrcode(0, 'L');
    qr.addData(url);
    qr.make();
    var qrCodeImage = qr.createImgTag(4);
  
    // Display the QR code in the container
    var qrCodeContainer = document.getElementById("qrcode-container");
    qrCodeContainer.innerHTML = qrCodeImage;
  }
  