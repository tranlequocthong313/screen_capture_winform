# Screen capture winform

#### Lấy ý tưởng từ Snipping Tool của Windows, có 6 chức năng chính:
 + Chụp full màn hình
 + Chụp phần nội dung do người dùng tự cắt
 + Lưu hình ảnh ra jpg, png, gif
 + Chạy trong background 
 + Sử dụng phím tắt để chụp
 + Thông báo khi chụp thành công
 
#### Tóm tắt cách làm: 
 + Chức năng thứ nhất, sử dụng class SendKeys và gọi đến phím "PRTSC" của Windows để chụp full màn hình
 + Chức năng thứ hai, tạo một Bitmap và bắt sự kiện MouseDown, MouseMove và MouseUp để vẽ 1 hình chữ nhật trên Bitmap sau đó sử dụng hàm CopyFromScreen từ Graphics và crop nó với hàm Clone từ Bitmap
 + Chức năng thứ ba, sử dụng SaveFileDialog với các Filters dành cho ảnh
 + Chức năng thứ tư, thêm ứng dụng vào Registry để tự động chạy khi máy tính khởi động và khi người dùng tắt bằng Form Control thì sẽ thu nhỏ vào Tray
 + Chức năng thứ năm, tạo một class và import user32.dll để đăng ký phím tắt cho ứng dụng
 + Chức năng thứ sáu, tạo một Form và gọi nó từ Form Main khi chụp thành công, sau 5 giây tự động tắt 
 
