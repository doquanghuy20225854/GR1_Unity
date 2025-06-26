# 🎮 Dự án Game 2D Unity - Platformer

## 📋 Mô tả
Đây là một game platformer 2D được phát triển bằng Unity Engine. Người chơi điều khiển một nhân vật có thể di chuyển, nhảy và thu thập đồng xu để ghi điểm. Game có hệ thống va chạm với bẫy và cơ chế Game Over.

## 🎯 Tính năng chính
- **Điều khiển nhân vật**: Di chuyển trái/phải và nhảy
- **Hệ thống điểm số**: Thu thập đồng xu để ghi điểm
- **Animation**: Nhân vật có animation cho trạng thái chạy, nhảy và đứng yên
- **Hệ thống va chạm**: Phát hiện va chạm với đồng xu và bẫy
- **Game Over**: Khi chạm vào bẫy, game sẽ kết thúc
- **UI**: Hiển thị điểm số và màn hình Game Over

## 🛠️ Công nghệ sử dụng
- **Unity Engine**: 2022.3.44f1
- **C#**: Ngôn ngữ lập trình chính
- **Universal Render Pipeline (URP)**: Pipeline render cho 2D
- **Input System**: Hệ thống input mới của Unity
- **TextMesh Pro**: Hiển thị text chất lượng cao
- **Cinemachine**: Camera system

## 📁 Cấu trúc dự án

### Assets/
```
Assets/
├── Animations/          # Animation controllers và clips
│   ├── Coin/           # Animation cho đồng xu
│   └── Player/         # Animation cho nhân vật
├── scripts/            # Các script C#
│   ├── GameManager.cs  # Quản lý game state và điểm số
│   ├── PlayerController.cs # Điều khiển nhân vật
│   └── PlayerCollision.cs # Xử lý va chạm
├── sprites/            # Hình ảnh 2D
│   ├── Player_*.png    # Sprite nhân vật
│   ├── Coin.png        # Sprite đồng xu
│   ├── Map.png         # Sprite bản đồ
│   └── Trap.png        # Sprite bẫy
├── Prefabs/            # Prefabs có thể tái sử dụng
├── Scenes/             # Các scene trong game
└── Tile/               # Tile assets cho bản đồ
```

## 🎮 Cách chơi

### Điều khiển
- **A/D hoặc ←/→**: Di chuyển trái/phải
- **Space**: Nhảy
- **ESC**: Tạm dừng game (nếu có)

### Mục tiêu
- Thu thập càng nhiều đồng xu càng tốt
- Tránh các bẫy để không bị Game Over
- Đạt điểm số cao nhất có thể

## 🚀 Cách chạy dự án

### Yêu cầu hệ thống
- Unity 2022.3.44f1 hoặc cao hơn
- Windows 10/11, macOS, hoặc Linux

### Cài đặt
1. Clone repository này về máy
2. Mở Unity Hub
3. Chọn "Open" và chọn thư mục dự án
4. Đợi Unity import tất cả assets
5. Mở scene `Assets/Scenes/SampleScene.unity`
6. Nhấn Play để chạy game

## 📝 Scripts chính

### GameManager.cs
- Quản lý điểm số và trạng thái game
- Xử lý Game Over
- Cập nhật UI

### PlayerController.cs
- Xử lý input từ người chơi
- Điều khiển di chuyển và nhảy
- Quản lý animation của nhân vật
- Kiểm tra va chạm với mặt đất

### PlayerCollision.cs
- Xử lý va chạm với đồng xu và bẫy
- Tương tác với GameManager để cập nhật điểm số

## 🎨 Assets

### Sprites
- **Player**: 3 trạng thái (Idle, Run, Jump)
- **Coin**: Đồng xu có thể thu thập
- **Trap**: Bẫy gây Game Over
- **Map**: Tileset cho bản đồ

### Animations
- **Player Animator**: Controller cho animation nhân vật
- **Coin Animator**: Animation xoay cho đồng xu

## 🔧 Tùy chỉnh

### Thay đổi tốc độ nhân vật
Trong `PlayerController.cs`, điều chỉnh các giá trị:
```csharp
[SerializeField] private float moveSpeed = 5f;    // Tốc độ di chuyển
[SerializeField] private float jumpForce = 3f;    // Lực nhảy
```

### Thêm điểm số cho đồng xu
Trong `PlayerCollision.cs`, thay đổi giá trị điểm:
```csharp
gameManager.AddScore(1); // Thay đổi số điểm nhận được
```

## 🐛 Xử lý lỗi thường gặp

### Lỗi import assets
- Đảm bảo Unity version tương thích
- Xóa thư mục Library/ và import lại

### Lỗi animation
- Kiểm tra Animator Controller có được gán đúng không
- Đảm bảo tên parameter trong script khớp với Animator

### Lỗi va chạm
- Kiểm tra Layer và Tag của các object
- Đảm bảo Collider2D được thiết lập đúng

## 📄 License
Dự án này được phát triển cho mục đích học tập và nghiên cứu.

## 👥 Đóng góp
Mọi đóng góp đều được chào đón! Vui lòng tạo issue hoặc pull request.

## 📞 Liên hệ
Nếu có câu hỏi hoặc góp ý, vui lòng liên hệ qua GitHub Issues.

---
**Lưu ý**: Đây là dự án demo, có thể cần điều chỉnh để phù hợp với nhu cầu cụ thể. 