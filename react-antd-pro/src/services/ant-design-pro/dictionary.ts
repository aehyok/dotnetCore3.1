import { request } from 'umi';

/** 通过字典类型获取字典项列表 GET /api/getUser */
export async function getDictionaryList() {
  return request<SYSTEM.MenuList>('/api/getDictionaryList', {
    method: 'GET',
  });
}

/** 通过菜单id获取菜单详情 GET /api/getMenu */
export async function getDictionaryTypeList() {
  return request<SYSTEM.ResultItem>('/api/getDictionaryTypeList', {
    method: 'GET',
  });
}
