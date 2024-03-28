# Product
class Rectangle:
    def __init__(self, width, height):
        self.width = width
        self.height = height

    # Fectory method
    @staticmethod
    def with_dimensions(width, height):
        return Rectangle(width, height)

    # Fectory method
    @staticmethod
    def with_area_and_ratio(area, ratio):
        height = (area / ratio) ** 0.5
        width = height * ratio
        return Rectangle(width, height)

rect1 = Rectangle.with_dimensions(10, 20)
print(f"Rectangle 1: {rect1.width} x {rect1.height}")

rect2 = Rectangle.with_area_and_ratio(200, 2)
print(f"Rectangle 2: {rect2.width} x {rect2.height}")
