--Insert Values into Brands Table
INSERT INTO Brands (Name, Country, Description, LogoUrl)
VALUES 
('Chanel', 'France', 'Iconic luxury fashion and fragrance house known for timeless elegance.', 'https://example.com/logos/chanel.png'),
('Dior', 'France', 'Prestige brand famous for sensual and bold perfumes like Sauvage and J’adore.', 'https://example.com/logos/dior.png'),
('Tom Ford', 'USA', 'Luxury designer with a bold and modern fragrance line including Black Orchid and Ombre Leather.', 'https://example.com/logos/tomford.png'),
('Creed', 'UK', 'Niche luxury brand with legacy scents like Aventus, known for high-end craftsmanship.', 'https://example.com/logos/creed.png'),
('Maison Francis Kurkdjian', 'France', 'Niche house known for the viral Baccarat Rouge 540 and refined compositions.', 'https://example.com/logos/mfk.png'),
('Versace', 'Italy', 'Italian fashion powerhouse with vibrant and youthful perfumes like Eros and Dylan Blue.', 'https://example.com/logos/versace.png'),
('Calvin Klein', 'USA', 'Minimalist and mass-appeal scents like CK One and Eternity.', 'https://example.com/logos/ck.png'),
('Armani', 'Italy', 'Elegant and refined brand with staples like Acqua Di Gio and Si.', 'https://example.com/logos/armani.png'),
('Yves Saint Laurent', 'France', 'French classic brand offering powerful scents like Libre and La Nuit de L’Homme.', 'https://example.com/logos/ysl.png'),
('Hugo Boss', 'Germany', 'Designer label with masculine, everyday scents like Boss Bottled.', 'https://example.com/logos/hugo.png');


--Insert Values into ScentCategories Table
INSERT INTO ScentCategories (CategoryName, Description)
VALUES
('Citrus', 'Refreshing and zesty scents derived from lemon, bergamot, lime, and orange.'),
('Woody', 'Earthy, warm aromas like sandalwood, cedarwood, and patchouli.'),
('Floral', 'Romantic and sweet notes of rose, jasmine, and lily.'),
('Oriental', 'Spicy and exotic notes with amber, vanilla, and resins.'),
('Fresh', 'Clean, airy, oceanic, and green scents for daily wear.');


--Insert Values into Products Table
INSERT INTO Products 
(Name, BrandId, ScentCategoryId, Description, Price, StockQuantity, Gender, ImageUrl, IsFeatured, CreatedAt, UpdatedAt)
VALUES
('Sauvage Elixir', 2, 4, 'An intense, spicy version of Dior Sauvage with warm oriental notes.', 7999.99, 20, 1, 'https://example.com/images/sauvage_elixir.jpg', 1, GETDATE(), GETDATE()),
('Acqua Di Gio Profumo', 8, 5, 'Sophisticated aquatic scent with incense and bergamot.', 6999.00, 15, 1, 'https://example.com/images/acqua_profumo.jpg', 1, GETDATE(), GETDATE()),
('Black Orchid', 3, 2, 'Unisex luxurious dark scent with truffle, chocolate, and florals.', 8299.99, 10, 0, 'https://example.com/images/black_orchid.jpg', 1, GETDATE(), GETDATE()),
('Baccarat Rouge 540', 5, 4, 'Amber, floral and woody — iconic and long-lasting.', 15999.99, 8, 2, 'https://example.com/images/baccarat.jpg', 1, GETDATE(), GETDATE()),
('CK One', 7, 1, 'Light, citrusy, unisex classic with mass appeal.', 2999.00, 30, 0, 'https://example.com/images/ck_one.jpg', 0, GETDATE(), GETDATE()),
('Libre Intense', 9, 3, 'A bold floral fragrance with orange blossom and lavender.', 6499.00, 12, 2, 'https://example.com/images/libre_intense.jpg', 1, GETDATE(), GETDATE()),
('Boss Bottled Night', 10, 2, 'Woody masculine scent for evening wear.', 4299.00, 22, 1, 'https://example.com/images/boss_night.jpg', 0, GETDATE(), GETDATE()),
('Dylan Blue Pour Femme', 6, 5, 'Fresh, fruity and floral scent by Versace for women.', 5199.00, 18, 2, 'https://example.com/images/dylan_blue.jpg', 1, GETDATE(), GETDATE()),
('Aventus', 4, 2, 'Creed’s signature powerful scent with pineapple, birch, and musk.', 13999.00, 6, 1, 'https://example.com/images/aventus.jpg', 1, GETDATE(), GETDATE()),
('Chance Eau Tendre', 1, 3, 'Soft floral-fruity mix with grapefruit and jasmine.', 5999.00, 14, 2, 'https://example.com/images/chance_tendre.jpg', 0, GETDATE(), GETDATE());
