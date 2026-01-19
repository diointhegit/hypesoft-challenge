"use client";
import { EllipsisVertical } from "lucide-react";

export default function ProfileButton() {
  return (
    <div className="flex items-center gap-10 text-sm min-w-[200px] h-fit py-2 justify-between hover:bg-neutral-200 transition-colors ease-in-out rounded-full px-5">
      <div className="flex items-center gap-2">
        <div className="leading-4">
          <p>Miguel</p>
          <p className="text-neutral-500 text-xs">Estoquista</p>
        </div>
      </div>
      <EllipsisVertical
        className="cursor-pointer"
        onClick={() => console.log("oi")}
      />
    </div>
  );
}
