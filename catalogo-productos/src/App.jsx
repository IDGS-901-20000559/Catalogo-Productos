import ProductDetail from "./components/ProductDetail";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Inicio from "./components/Inicio";


const App = () => {
  return (
	<BrowserRouter>
      <Routes>
        <Route path="/" element={<Inicio />} />
        <Route path="/detalle/:id" element={<ProductDetail/>} />
      </Routes>
    </BrowserRouter>
  )
}

export default App