import {
  Sidebar,
  SidebarContent,
  SidebarFooter,
  SidebarGroup,
  SidebarGroupContent,
  SidebarGroupLabel,
  SidebarMenu,
  SidebarMenuButton,
  SidebarMenuItem,
} from "@/components/ui/sidebar";
import ProfileButton from "./Profile-Button";
import { ChartNoAxesColumn, EllipsisVertical, List } from "lucide-react";

// Menu items.

const items = [
  {
    title: "Geral",
    subItems: [
      {
        title: "Dashboard",
        url: "/",
        icon: ChartNoAxesColumn,
      },
    ],
  },
  {
    title: "Produtos",
    subItems: [
      {
        title: "Ver Lista",
        url: "/produtos",
        icon: List,
      },
      {
        title: "Categorias",
        url: "/categorias",
        icon: EllipsisVertical,
      },
    ],
  },
];

export default function Sidenav() {
  return (
    <Sidebar>
      <SidebarContent>
        <div>
          {items.map((category: any) => {
            return (
              <SidebarGroup>
                <SidebarGroupLabel>{category.title}</SidebarGroupLabel>
                <SidebarGroupContent>
                  <SidebarMenu>
                    {category.subItems.map((item: any) => (
                      <SidebarMenuItem key={item.title}>
                        <SidebarMenuButton asChild>
                          <a href={item.url}>
                            <item.icon />
                            <span>{item.title}</span>
                          </a>
                        </SidebarMenuButton>
                      </SidebarMenuItem>
                    ))}
                  </SidebarMenu>
                </SidebarGroupContent>
              </SidebarGroup>
            );
          })}
        </div>
      </SidebarContent>
      <SidebarFooter>
        <ProfileButton />
      </SidebarFooter>
    </Sidebar>
  );
}
