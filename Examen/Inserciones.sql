INSERT INTO Categorias (Nombre) VALUES
('Electrónica'),
('Hogar'),
('Ropa'),
('Deportes');
INSERT INTO Productos (Nombre, Precio, CategoriaId) VALUES
('Smartphone X100', 599.90, 1),
('Auriculares Bluetooth', 79.99, 1),
('Tablet Pro 10"', 299.50, 1),
('Aspiradora Turbo', 149.99, 2),
('Cafetera Automática', 89.95, 2),
('Camiseta Basic', 12.99, 3),
('Pantalón Vaquero', 34.50, 3),
('Balón de Fútbol', 24.90, 4),
('Raqueta de Tenis', 45.00, 4);
INSERT INTO Ventas (ProductoId, Cantidad, FechaVenta, Cliente) VALUES
(1, 2, '2025-01-10', 'Carlos Pérez'),
(2, 1, '2025-01-12', 'Ana López'),
(3, 1, '2025-01-15', 'David Sánchez'),
(4, 1, '2025-02-01', 'Laura García'),
(5, 3, '2025-02-03', 'José Martínez'),
(6, 5, '2025-03-02', 'Sara Rodríguez'),
(7, 2, '2025-03-05', 'Patricia Navarro'),
(8, 4, '2025-03-20', 'Mario Torres'),
(9, 1, '2025-03-23', 'Lucía Herrera')