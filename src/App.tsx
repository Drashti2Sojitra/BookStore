import React from "react";
import { ThemeProvider } from "@material-ui/core/styles";
import { BrowserRouter } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

import "./assets/css/style.css";
import { theme } from "./utils/theme";
import MainNavigation from "./component/MainNavigation";
import Header from "./component/header";
import Footer from "./component/footer";
import { AuthWrapper } from "./context/auth";

function App() {
  return (
    <ThemeProvider theme={theme}>
      <React.Suspense fallback={<></>}>
        <BrowserRouter>
        <AuthWrapper>
          <div className="wrapper">
          <Header />
            <main>
              <MainNavigation />
            </main>
            <Footer />
          </div>
          </AuthWrapper>
          <ToastContainer />
        </BrowserRouter>
      </React.Suspense>
    </ThemeProvider>
  );
}

export default App;
