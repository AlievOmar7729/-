using Bridge;

Shape triangle = new Triangle(new VectorGraphics());
triangle.Draw();
triangle.SetRender(new RasterGraphics());
triangle.Draw();

Shape cirle = new Circle(new RasterGraphics());
cirle.Draw();
cirle.SetRender(new VectorGraphics());
cirle.Draw();

