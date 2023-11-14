import { Link } from "react-router-dom";


const Productos = ({ products }) => {
    // Función para determinar la clase de estilo según la categoría
    const getArticleStyle = (category) => {
        switch (category.toLowerCase()) {
            case 'smartphones':
                return 'style3';
            case 'laptops':
                return 'style2';
            case 'fragrances':
                return 'style1';
            case 'skincare':
                return 'style4';
            case 'groceries':
                return 'style5';
            case 'home-decoration':
                return 'style6';
            default:
                return '';
        }
    };

    if (products.length === 0) {
        return (
        <center>
            <h2 style={{color:"red"}}>No se encontraron resultados</h2>
            <h5>Prueba buscando con otro nombre</h5>
        </center>
        );
    }

    return (
        <>
            <section className="tiles">
                {
                    products.map((product, index) => (
                        <article className={getArticleStyle(product.categoria)} key={index}>
                            <span className="image">
                                <img src={product.imagen} alt="" width={200} height={200} />
                            </span>
                            <Link to={`/detalle/${product.id}`} style={{ textDecoration: 'none', color: 'inherit' }}>
                                <a>
                                    <h2>{product.nombre}</h2>
                                    <div className="content">
                                        <p className="text-warning"><s>${(product.precio / (1 - product.descuentoPorcentaje / 100)).toFixed(2)}</s></p>
                                        <p style={{ color: "#51EC08", boxShadow: "inherit" }}>
                                            <b>${product.precio}</b>
                                        </p>
                                    </div>
                                </a>
                            </Link>
                        </article>
                    ))
                }
            </section>
        </>
    );
};

export default Productos;
