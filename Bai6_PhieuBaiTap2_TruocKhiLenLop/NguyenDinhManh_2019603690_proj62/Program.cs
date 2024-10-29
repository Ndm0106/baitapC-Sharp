namespace NguyenDinhManh_2019603690_proj62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            int choice;

            do
            {
                Console.WriteLine("Chọn một tùy chọn:");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Hiển thị dữ liệu");
                Console.WriteLine("3. Tìm kiếm theo ID");
                Console.WriteLine("4. Tìm kiếm theo Maker");
                Console.WriteLine("5. Sắp xếp theo Price");
                Console.WriteLine("6. Sắp xếp theo Year");
                Console.WriteLine("7. Nhập thêm phương tiện");
                Console.WriteLine("8. Xóa phương tiện theo ID");
                Console.WriteLine("9. Sửa thông tin phương tiện theo ID");
                Console.WriteLine("10. Kết thúc");
                Console.Write("Nhập tùy chọn của bạn: ");

                // Kiểm soát lỗi khi nhập lựa chọn
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    continue;
                }

                switch (choice)
                {
                    case 1: // Nhập dữ liệu
                        Console.WriteLine("Nhập thông tin cho 3 xe hơi:");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"\nNhập xe hơi thứ {i + 1}:");
                            Car car = new Car();
                            car.Input();
                            vehicles.Add(car);
                        }

                        Console.WriteLine("Nhập thông tin cho 3 xe tải:");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"\nNhập xe tải thứ {i + 1}:");
                            Truck truck = new Truck();
                            truck.Input();
                            vehicles.Add(truck);
                        }
                        break;

                    case 2: // Hiển thị dữ liệu
                        Console.WriteLine("\nThông tin tất cả các phương tiện:");
                        foreach (var vehicle in vehicles)
                        {
                            vehicle.Output();
                            Console.WriteLine();
                        }
                        break;

                    case 3: // Tìm kiếm theo ID
                        Console.Write("Nhập ID cần tìm: ");
                        string searchId = Console.ReadLine();
                        var foundById = vehicles.FirstOrDefault(v => v.Id.Equals(searchId, StringComparison.OrdinalIgnoreCase));
                        if (foundById != null)
                        {
                            Console.WriteLine("Tìm thấy phương tiện:");
                            foundById.Output();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy phương tiện với ID đó.");
                        }
                        break;

                    case 4: // Tìm kiếm theo Maker
                        Console.Write("Nhập Maker cần tìm: ");
                        string searchMaker = Console.ReadLine();
                        var foundByMaker = vehicles.Where(v => v.Maker.Equals(searchMaker, StringComparison.OrdinalIgnoreCase)).ToList();

                        if (foundByMaker.Count > 0)
                        {
                            Console.WriteLine("Tìm thấy các phương tiện:");
                            foreach (var vehicle in foundByMaker)
                            {
                                vehicle.Output();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy phương tiện với Maker đó.");
                        }
                        break;

                    case 5: // Sắp xếp theo Price
                        Console.WriteLine("\nDanh sách phương tiện trước khi sắp xếp theo giá:");
                        foreach (var vehicle in vehicles)
                        {
                            vehicle.Output();
                            Console.WriteLine();
                        }

                        var sortedByPrice = vehicles.OrderBy(v => v.Price).ToList();
                        Console.WriteLine("\nDanh sách phương tiện sau khi sắp xếp theo giá:");
                        foreach (var vehicle in sortedByPrice)
                        {
                            vehicle.Output();
                            Console.WriteLine();
                        }
                        break;

                    case 6: // Sắp xếp theo Year
                        Console.WriteLine("\nDanh sách phương tiện trước khi sắp xếp theo năm:");
                        foreach (var vehicle in vehicles)
                        {
                            vehicle.Output();
                            Console.WriteLine();
                        }

                        var sortedByYear = vehicles.OrderBy(v => v.Year).ToList();
                        Console.WriteLine("\nDanh sách phương tiện sau khi sắp xếp theo năm:");
                        foreach (var vehicle in sortedByYear)
                        {
                            vehicle.Output();
                            Console.WriteLine();
                        }
                        break;

                    case 7: // Nhập thêm phương tiện
                        Console.WriteLine("Nhập thêm phương tiện (1: Xe hơi, 2: Xe tải): ");
                        if (int.TryParse(Console.ReadLine(), out int vehicleType))
                        {
                            if (vehicleType == 1) // Xe hơi
                            {
                                Car car = new Car();
                                car.Input();
                                vehicles.Add(car);
                            }
                            else if (vehicleType == 2) // Xe tải
                            {
                                Truck truck = new Truck();
                                truck.Input();
                                vehicles.Add(truck);
                            }
                            else
                            {
                                Console.WriteLine("Loại phương tiện không hợp lệ.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nhập không hợp lệ.");
                        }
                        break;

                    case 8: // Xóa phương tiện theo ID
                        Console.Write("Nhập ID của phương tiện cần xóa: ");
                        string idToDelete = Console.ReadLine();
                        var vehicleToDelete = vehicles.FirstOrDefault(v => v.Id.Equals(idToDelete, StringComparison.OrdinalIgnoreCase));

                        if (vehicleToDelete != null)
                        {
                            vehicles.Remove(vehicleToDelete);
                            Console.WriteLine("Đã xóa phương tiện.");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy phương tiện với ID đó.");
                        }
                        break;

                    case 9: // Sửa thông tin phương tiện theo ID
                        Console.Write("Nhập ID của phương tiện cần sửa: ");
                        string idToEdit = Console.ReadLine();
                        var vehicleToEdit = vehicles.FirstOrDefault(v => v.Id.Equals(idToEdit, StringComparison.OrdinalIgnoreCase));

                        if (vehicleToEdit != null)
                        {
                            Console.WriteLine("Thông tin hiện tại của phương tiện:");
                            vehicleToEdit.Output();
                            Console.WriteLine("Nhập thông tin mới cho phương tiện:");
                            vehicleToEdit.Input();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy phương tiện với ID đó.");
                        }
                        break;

                    case 10: // Kết thúc
                        Console.WriteLine("Kết thúc chương trình.");
                        break;

                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine(); // Xuống dòng
            } while (choice != 10);
        }
    }
}
