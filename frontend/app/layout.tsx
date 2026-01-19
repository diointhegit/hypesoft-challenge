import type { Metadata } from "next";
// import localFont from "next/font/local";
import "./globals.css";
import Topnav from "./components/ui/Topnav";
import Sidenav from "./components/ui/Sidenav";
import { SidebarProvider } from "@/components/ui/sidebar";

// const geistSans = localFont({
//   src: "./fonts/GeistVF.woff",
//   variable: "--font-geist-sans",
//   weight: "100 900",
// });
// const geistMono = localFont({
//   src: "./fonts/GeistMonoVF.woff",
//   variable: "--font-geist-mono",
//   weight: "100 900",
// });

export const metadata: Metadata = {
  title: "Hypesoftstore",
  description: "Store with products from Hypesoft",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={`antialiased`}>
        <SidebarProvider>
          <Sidenav />
          <main>{children}</main>
        </SidebarProvider>
      </body>
    </html>
  );
}
