# Quan_ly_project – Tổng quan dự án (.NET MAUI + SQLite)

## Kiến trúc & Công nghệ
- **UI**: .NET MAUI (XAML + code-behind), đa nền tảng: Android, iOS, MacCatalyst, Windows
- **DI/Khởi tạo**: `MauiProgram.CreateMauiApp()` đăng ký ViewModel/Service qua DI container
- **Điều hướng**: `App.xaml` khai báo `Shell` (Login, Register, Home); `App.xaml.cs` đặt `MainPage` là `NavigationPage(LoginPage)`
- **Dữ liệu**: SQLite cục bộ với `sqlite-net-pcl`
- **Layering**:
  - Models: `User`, `Project`, `ProjectTask`, `ProjectMember`
  - Data (Repositories): CRUD qua `SQLiteConnection` tạo bởi `DatabaseHelper`
  - Services: `AuthService`, `PermissionService`
  - ViewModels: logic trình bày (đăng ký trong DI)
  - Views: XAML pages (Login/Register/Home/Project/Task/ProjectMember)

## Cấu trúc thư mục chính
- `Quan_ly_project/`
  - `App.xaml`, `App.xaml.cs`: cấu hình `Shell` và trang khởi tạo
  - `MauiProgram.cs`: đăng ký DI cho VM/Services
  - `Models/`: thực thể database
  - `Data/`: lớp truy cập dữ liệu (Repository) + `DatabaseHelper`
  - `Services/`: dịch vụ domain (Auth, Permission)
  - `ViewModels/`: lớp ViewModel tương ứng các màn hình
  - `Views/`: XAML pages + code-behind
  - `Resources/`: fonts, images, styles, splash, app icon
  - `Platforms/`: entrypoint và cấu hình từng nền tảng
  - `Quan_ly_project.csproj`: cấu hình target frameworks, packages

## Dòng chảy ứng dụng (High-level)
1. Ứng dụng khởi tạo qua `MauiProgram.CreateMauiApp()` → cấu hình fonts, DI.
2. `App` khởi động, đặt `MainPage` là `NavigationPage(new LoginPage())`.
3. Người dùng đăng nhập/đăng ký (qua `AuthService` + `UserRepository`).
4. Sau khi đăng nhập, điều hướng đến `HomePage` và các trang quản lý Project/Task/Member.

## Data Layer
- `DatabaseHelper.GetConnection()`
  - Tạo file DB tại thư mục LocalApplicationData: `QuanLyPhanMem.db3`
  - Bật `PRAGMA foreign_keys = ON`
  - Tạo bảng: `User`, `Project`, `ProjectTask`, `ProjectMember`
- Repositories:
  - `UserRepository`: Add/GetById/GetByUsername/GetAll/Update/Delete
  - `ProjectRepository`: Add (tránh trùng theo Name+CreatedBy), GetById/GetAll/Update/Delete
  - `TaskRepository`: Add/GetById/GetByProjectId/Update/Delete/DeleteAll
  - `ProjectMemberRepository`: Add/GetMembersByProjectId/Update/RemoveMember

## Services
- `AuthService`
  - Khởi tạo `UserRepository`
  - `AuthenticateUser(username, password)`: so khớp Username/Password thuần (chưa hash)
  - `GetUserByUsername(username)`
  - `Logout()` placeholder
- `PermissionService`
  - `HasAdminAccess(role)` → true khi role == "Admin"
  - `HasUserAccess(role)` → true khi role == "User"

## Models (SQLite)
- `User`: `UserId` PK, `Username`, `Password`, `FullName`, `Email`, `Role`, `CreatedAt`
- `Project`: `ProjectId` PK, `Name`, `Description`, `StartDate`, `EndDate`, `CreatedBy`, `CreatedAt`
- `ProjectTask`: `TaskId` PK, `ProjectId`, `Name`, `Description`, `Status`, `ProgressPercent`, `AssigneeId`, `Deadline`, `CreatedAt`
- `ProjectMember`: `MemberId` PK, `UserName`, `Role`, `ProjectId`, `UserId`, `JoinedAt`

## Views & Navigation
- `App.xaml` Shell: route `LoginPage`, `RegisterPage`, `HomePage`
- `App.xaml.cs`: dùng `NavigationPage` để đảm bảo điều hướng stack-based từ `LoginPage`
- Các trang khác: `ProjectPage`, `TaskPage`, `ProjectMemberPage`, `HomePage2`

## Cấu hình dự án
- Target frameworks: `net9.0-android; net9.0-ios; net9.0-maccatalyst; net9.0-windows10.0.19041.0`
- Packages: `Microsoft.Maui.Controls`, `Microsoft.Extensions.Logging.Debug`, `sqlite-net-pcl`

## Cách chạy nhanh
- Mở solution `Quan_ly_project.sln` bằng Visual Studio 2022+ (đã cài workload .NET MAUI)
- Chọn target (Android Emulator, Windows, iOS/MacCatalyst nếu có môi trường)
- Run (F5)

## Điểm mạnh / Cần cải thiện
- Điểm mạnh: cấu trúc rõ ràng MVVM+Repository, DB cục bộ, DI chuẩn MAUI.
- Cần cải thiện:
  - Bảo mật: hiện so khớp mật khẩu thuần; nên dùng hash (ví dụ BCrypt) + salt.
  - Quan hệ khoá ngoại: hiện chưa có `[ForeignKey]`/ràng buộc ở model; cân nhắc thêm và enforce cascade.
  - Validation: thêm kiểm tra dữ liệu ở VM/Service (rỗng, độ dài, format email,...).
  - Navigation: hợp nhất `Shell` và `NavigationPage` cho nhất quán (ưu tiên `Shell`).
  - Error handling & logging: thêm try/catch có xử lý hữu ích ở repository/service.

## Liên quan
- File hướng dẫn gốc: `README.md` (mô tả tính năng, công nghệ, cài đặt)
